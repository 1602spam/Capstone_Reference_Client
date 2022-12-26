using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Google.Apis.Drive.v3;
using Google.Apis.Http;
using static System.Formats.Asn1.AsnWriter;
using static Google.Apis.Drive.v3.DriveService;

namespace GoogleDriveSave
{
	public class GoogleDrive
	{
		
		public static void GoogleDriveSave(string TargetPath, string DriveURL, string jsonKeyPath)
        {
            //json파일을 저장하는 파일스트림 변수 생성
            FileStream? fs;

            //파일이름을 저장하는 파일스트림 변수 생성
            FileStream? fsu;

            //API를 사용할때 접근가능한 범위를 지정(드라이브에 접근하여 파일을 읽거나 쓸수있는 권한)
            string[] Scopes = { DriveService.Scope.Drive };

            //자격증명 생성을 위한 선언
            Google.Apis.Auth.OAuth2.GoogleCredential credential;

            //클라이언트 서비스의 이니셜라이저 생성하기위한 선언
            Google.Apis.Services.BaseClientService.Initializer init;

            // 인터페이스 보고 업로드 진행률을 저장하는 변수생성
            Google.Apis.Upload.IUploadProgress? prog = null;



            //json파일 처리
            Openjson(out fs, jsonKeyPath);
			if (fs == null)
			{
				return;
			}

            //파일 처리
            OpenFile(out fsu, TargetPath);
            if (fsu == null)
            {
                return;
            }

            //OAuth 2.0을 사용하여 호출을 승인하기 위한 자격 증명 생성
            Opencredential(out credential,fs, Scopes);

            //클라이언트 서비스의 이니셜라이저 클래스 생성
            OpenInitializer(out init, credential);

            // init을 매개변수로 한 DriveService객체 생성
            DriveService service = new DriveService(init);  

            //파일 업로드
            FileUpload(TargetPath, DriveURL, fsu, service, prog);

            return;
		}


		private static void Openjson(out FileStream? fs ,string jsonKeyPath)
		{
			try //json파일 오류시 위치
			{
				//json파일을 읽기전용 공유모드로 객체 생성
				fs = new FileStream(jsonKeyPath, FileMode.Open, FileAccess.Read);
			}
			catch (Exception a)
			{
				Console.WriteLine("json파일 위치가 맞지않습니다");
				Console.WriteLine(a);
				fs = null;
			}
		}

        private static void Opencredential(out Google.Apis.Auth.OAuth2.GoogleCredential credential, FileStream fs, string[] Scopes)
		{
            //자격증명 생성을 위한 선언
            try
            {
                //json파일을 읽어 지정된 범위에 권한을 설정
                credential = Google.Apis.Auth.OAuth2.GoogleCredential.FromStream(fs).CreateScoped(Scopes);
            }
            finally
            {
                fs.Close();
            }
        }

        private static void OpenInitializer(out Google.Apis.Services.BaseClientService.Initializer init, Google.Apis.Auth.OAuth2.GoogleCredential credential)
		{
            //클라이언트 서비스의 이니셜라이저 클래스 생성
            init = new Google.Apis.Services.BaseClientService.Initializer();
			//ConfigurableHttpClient 및 ConfigurableMessageHandler 의 속성을 credential로 설정한다 
			init.HttpClientInitializer = credential;
			// User-Agent 헤더에서 사용할 애플리케이션 이름을 가져오거나 설정합니다
            init.ApplicationName = "My Test App";
        }
        private static void OpenFile(out FileStream? fsu, string TargetPath)
		{
            try// 파일 이름 잘못들어왔을경우 예외처리
            {
                fsu = new FileStream(TargetPath, FileMode.Open);
            }
            catch (Exception e)
            {
                Console.WriteLine("파일이름이 잘못되었습니다.");
                Console.WriteLine(e);
                fsu = null;
            }
        }

        private static void FileUpload(string TargetPath,string DriveURL, FileStream fsu, DriveService service, Google.Apis.Upload.IUploadProgress? prog)
		{
            try
            {
                //System.Web.MimeMapping.GetMimeMapping fpv = new System.Web.MimeMapping.GetMimeMapping();

                //파일 확장자와 MIME 유형 간의 매핑을 제공을 위한 객체 생성
                Microsoft.AspNetCore.StaticFiles.FileExtensionContentTypeProvider fpv = new Microsoft.AspNetCore.StaticFiles.FileExtensionContentTypeProvider();
                string ContentType;
                //TargetPath에서 MiME타입을 받아 ContentType에 저장한다
                fpv.TryGetContentType(TargetPath, out ContentType);


                //파일업로드를 위하여 meta data생성을 위한 객체생성
                Google.Apis.Drive.v3.Data.File meta = new Google.Apis.Drive.v3.Data.File();
                meta.Name = Path.GetFileName(TargetPath);
                meta.MimeType = ContentType;
                meta.Parents = new List<string>() { DriveURL };


                //구글 드라이브에 파일 업로드를 위한 파일생성  
                Google.Apis.Drive.v3.FilesResource.CreateMediaUpload req = service.Files.Create(meta, fsu, ContentType);

                //미안하다 뭔지 모르겠는데 없어도 돌아간다 
                //req.Fields = "id, name";

                //업로드부분
                prog = req.Upload();
            }
            finally
            {
                fsu.Close();
            }
        }


       



    }
}