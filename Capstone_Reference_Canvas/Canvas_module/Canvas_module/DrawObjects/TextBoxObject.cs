using Canvas_module.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas_module.DrawObjects
{
	[Serializable]
	class TextBoxObject : DrawObject
	{
		


		private Rectangle rectangle;
		
	 

		public TextBoxObject() : this(0, 0, 1, 1)
		{

		}

		public TextBoxObject(int x, int y, int width, int height)
			: base()
		{
			rectangle.X = x;
			rectangle.Y = y;
			rectangle.Width = width;
			rectangle.Height = height;
			
            Initialize();
		}


		/// <summary>
		/// 이 객체를 복사한다.
		/// </summary>
		public override DrawObject Clone()
		{
			TextBoxObject txtboxobj = new TextBoxObject();
			txtboxobj.rectangle = this.rectangle;

			FillDrawObjectFields(txtboxobj);
			return txtboxobj;
		}


		/// <summary>
		/// 이 객체를 그려준다.
		/// </summary>
		public override void Draw(Graphics g, string context)
		{
			using (Pen pen = new Pen(Color, PenWidth))
			{
			
				g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
				g.DrawRectangle(pen, TextBoxObject.GetNormalizedRectangle(Rectangle));

				RectangleF rf = new RectangleF(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);

			    g.DrawString(context, new Font("Arial", 20), new SolidBrush(Color.Gray), rf);
				
				
			}
		}

	

		//Retangle 의 크기와 위치를 설정한다.
		protected void SetRectangle(int x, int y, int width, int height)
		{
			rectangle.X = x;
			rectangle.Y = y;
			rectangle.Width = width;
			rectangle.Height = height;
		}

		/// <summary>
		/// 핸들 넘버의 위치를 반환한다.
		/// </summary>
		public override Point GetHandle(int handleNumber)
		{
			int x, y, xCenter, yCenter;

			xCenter = rectangle.X + rectangle.Width / 2;
			yCenter = rectangle.Y + rectangle.Height / 2;
			x = rectangle.X;
			y = rectangle.Y;

			switch (handleNumber)
			{
				case 1:
					x = rectangle.X;
					y = rectangle.Y;
					break;
				case 2:
					x = xCenter;
					y = rectangle.Y;
					break;
				case 3:
					x = rectangle.Right;
					y = rectangle.Y;
					break;
				case 4:
					x = rectangle.Right;
					y = yCenter;
					break;
				case 5:
					x = rectangle.Right;
					y = rectangle.Bottom;
					break;
				case 6:
					x = xCenter;
					y = rectangle.Bottom;
					break;
				case 7:
					x = rectangle.X;
					y = rectangle.Bottom;
					break;
				case 8:
					x = rectangle.X;
					y = yCenter;
					break;
			}

			return new Point(x, y);

		}

		/// <summary>
		///  마우스가 클릭된 위치가 DrawObject를 포함하는지 알려준다
		///  -1 - no hit
		///   0 - hit anywhere
		/// > 1 - handle number
		/// </summary>
		public override int HitTest(Point point)
		{
			if (Selected)
			{
				for (int i = 1; i <= HandleCount; i++)
				{
					if (GetHandleRectangle(i).Contains(point))
						return i;
				}
			}

			if (PointInObject(point))
				return 0;

			return -1;
		}

		/// <summary>
		/// 마우스의 위치가 DrawObject 내에 있는지 알려준다.
		/// </summary>
		protected override bool PointInObject(Point point)
		{
			return rectangle.Contains(point);
		}


		/// <summary>
		/// Pointer 의 HandleNumber 에 따라서 마우스 커서를 반환한다.
		/// </summary>
		public override Cursor GetHandleCursor(int handleNumber)
		{
			switch (handleNumber)
			{
				case 1:
					return Cursors.SizeNWSE;
				case 2:
					return Cursors.SizeNS;
				case 3:
					return Cursors.SizeNESW;
				case 4:
					return Cursors.SizeWE;
				case 5:
					return Cursors.SizeNWSE;
				case 6:
					return Cursors.SizeNS;
				case 7:
					return Cursors.SizeNESW;
				case 8:
					return Cursors.SizeWE;
				default:
					return Cursors.Default;
			}
		}

		/// <summary>
		/// DrawObject 의 사이즈를 변경한다.
		/// </summary>
		public override void MoveHandleTo(Point point, int handleNumber)
		{
			int left = Rectangle.Left;
			int top = Rectangle.Top;
			int right = Rectangle.Right;
			int bottom = Rectangle.Bottom;

			switch (handleNumber)
			{
				case 1:
					left = point.X;
					top = point.Y;
					break;
				case 2:
					top = point.Y;
					break;
				case 3:
					right = point.X;
					top = point.Y;
					break;
				case 4:
					right = point.X;
					break;
				case 5:
					right = point.X;
					bottom = point.Y;
					break;
				case 6:
					bottom = point.Y;
					break;
				case 7:
					left = point.X;
					bottom = point.Y;
					break;
				case 8:
					left = point.X;
					break;
			}

			SetRectangle(left, top, right - left, bottom - top);
		}

		/// <summary>
		/// DrawObject가 rectangle 에 포함되는지 알려준다.
		/// </summary>
		public override bool IntersectsWith(Rectangle rectangle)
		{
			return Rectangle.IntersectsWith(rectangle);
		}

		/// <summary>
		/// DrawObject 의 위치를 이동한다.
		/// </summary>
		public override void Move(int deltaX, int deltaY)
		{
			rectangle.X += deltaX;
			rectangle.Y += deltaY;
		}

		/// <summary>
		/// DrawObject 를 새로 그리거나, 사이즈를 변경이 끝났을 때 호출된다.
		/// </summary>
		public override void Normalize()
		{
			rectangle = TextBoxObject.GetNormalizedRectangle(rectangle);
		}


		/// <summary>
		/// Retagle을 그려준다
		/// </summary>
		public static Rectangle GetNormalizedRectangle(int x1, int y1, int x2, int y2)
		{
			if (x2 < x1)
			{
				int tmp = x2;
				x2 = x1;
				x1 = tmp;
			}

			if (y2 < y1)
			{
				int tmp = y2;
				y2 = y1;
				y1 = tmp;
			}

			return new Rectangle(x1, y1, x2 - x1, y2 - y1);
		}

		/// <summary>
		/// Retagle을 그려준다
		/// </summary>
		public static Rectangle GetNormalizedRectangle(Point p1, Point p2)
		{
			return GetNormalizedRectangle(p1.X, p1.Y, p2.X, p2.Y);
		}

		/// <summary>
		/// Retagle을 그려준다
		/// </summary>
		public static Rectangle GetNormalizedRectangle(Rectangle r)
		{
			return GetNormalizedRectangle(r.X, r.Y, r.X + r.Width, r.Y + r.Height);
		}

	 

		/// <summary>
		/// 핸들의 숫자를 반환한다.
		/// </summary>
		public override int HandleCount
		{
			get
			{
				return 8;
			}
		}

		protected Rectangle Rectangle
		{
			get
			{
				return rectangle;
			}
			set
			{
				rectangle = value;
			}
		}

	
	   

	}
}
