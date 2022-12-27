using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Example
{
    // 퍼즐 박스
    class Box
    {
        // 퍼즐 박스 크기
        private const int BOX_SIZE = 50;
        // 폰트 크기
        private const int FONT_SIZE = 20;
        // 폰트 설정
        private Font FONT = new Font(new FontFamily("Arial"), FONT_SIZE, FontStyle.Bold, GraphicsUnit.Pixel);
        // 색 설정
        private Brush COLOR = new SolidBrush(Color.Black);
        // 이미지 가져오기
        private Image BOX = Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory + "box.bmp");
        // 공객 이미지 가져오기
        private Image BLANK = Bitmap.FromFile(AppDomain.CurrentDomain.BaseDirectory + "blank.bmp");

        // 퍼즐의 번호, 기본 마스크 설정
        public Box(int number, Mask mask)
        {
            // 퍼즐 번호 설정
            this.Number = number;
            // 마스크 설정
            this.Mask = mask;
        }
        // 번호 취득
        public int Number
        {
            get;
            private set;
        }
        // 마스크 취득
        public Mask Mask
        {
            get;
            set;
        }
        // 그리기 (x 좌표, y 좌표)
        public void Render(int x, int y)
        {
            // 0이면 공백 퍼즐임
            if (Number == 0)
            {
                // Bitmap 그리기
                GDIBuffer.Graphics(g => g.DrawImage(BLANK, x, y, BOX_SIZE, BOX_SIZE));
                return;
            }
            // 글자의 위치 계산하기
            float pointX = x + (BOX_SIZE / 2 - (FONT_SIZE / 2 + (int)Math.Log10(Number) * FONT_SIZE / 2)) + (Number > 9 ? 5 : 0);
            float pointY = y + BOX_SIZE / 2 - FONT_SIZE / 2;
            // Bitmap 그리기
            GDIBuffer.Graphics(g => g.DrawImage(BOX, x, y, BOX_SIZE, BOX_SIZE));
            // 번호 그리기
            GDIBuffer.Graphics(g => g.DrawString(Number.ToString(), FONT, COLOR, new PointF(pointX, pointY)));
        }
    }
    // 마스크 클래스(Box와 그릴 위치 좌표)
    class Mask
    {
        // 마스크 생성
        public Mask(int index, int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Index = index;
            // Box 인스턴스 생성
            this.Box = new Box(index, this);
        }
        // 퍼즐 박스
        public Box Box
        {
            set;
            get;
        }
        // X좌표 위치 설정
        public int X
        {
            private set;
            get;
        }
        // Y좌표 위치 설정
        public int Y
        {
            private set;
            get;
        }
        // 마스크 위치 설정
        public int Index
        {
            private set;
            get;
        }
    }
    // 박스 테이블 (마스크 리스트를 상속)
    class BoxTable : List<Mask>
    {
        // 박스는 좌로 5 세로 5의 총 25개 설정
        private const int BOX_COUNT = 25;
        // 공백 박스 클래스
        private Box blankBox;
        // 섞기 초기 플러그
        public bool Init
        {
            get; set;
        }
        // 완료 플러그
        public bool Complete
        {
            get; set;
        }
        // 생성장
        public BoxTable()
        {
            //초기화 플러그 설정
            Init = true;
            // 완료 플러그 설정
            Complete = false;
            // 마스크 생성하기
            CreateMask();

        }
        // 블랭크 박스 이동하기
        public void MoveBlank(Keys key)
        {
            // 퍼즐이 맞춤이 완료되면 이동 금지
            if (Complete)
            {
                return;
            }
            // Blank 위치 찾아오기
            int pos = blankBox.Mask.Index;
            // 이동할 위치
            int mpos;
            // 오른쪽 이동
            if (key == Keys.Right)
            {
                // 오른쪽 끝이면 이동 못한다.
                if (pos % 5 == 4)
                {
                    return;
                }
                // 이동
                mpos = pos + 1;
            }
            // 왼쪽 이동
            else if (key == Keys.Left)
            {
                // 왼쪽 끝이면 이동 못한다.
                if (pos % 5 == 0)
                {
                    return;
                }
                // 이동
                mpos = pos - 1;
            }
            // 아래로 이동
            else if (key == Keys.Down)
            {
                // 아래쪽과 배열 차이는 5
                mpos = pos + 5;
            }
            // 위로 이동
            else if (key == Keys.Up)
            {
                // 위쪽과의 배열 차이는 5
                mpos = pos - 5;
            }
            else
            {
                // 그 외의 버튼은 관계없음
                return;
            }
            // 배열 범위를 넘어서면 리턴
            if (mpos < 0 || mpos >= BOX_COUNT)
            {
                return;
            }
            // 마스크의 박스 객체 교환(Swap)
            // 공백 박스가 있던 마스크에 이동할 박스를 넣는다.
            blankBox.Mask.Box = base[mpos].Box;
            // 기존의 이동한 박스에 공백 박스를 넣는다.
            base[mpos].Box = blankBox;

            // 각 박스의 마스크 재설정
            base[pos].Box.Mask = base[pos];
            base[mpos].Box.Mask = base[mpos];

            // 랜덤 섞기가 끝난 상황이라면
            if (!Init)
            {
                // 완료했는지 확인한다.
                if (Check())
                {
                    // 완료 플로그 설정
                    Complete = true;
                    // 메시지 출력
                    MessageBox.Show("Complete!!");
                }
            }
        }
        // 퍼즐 확인 함수
        private bool Check()
        {
            // 각 마스크의
            for (int i = 0; i < base.Count; i++)
            {
                // 번호가 순서대로 있으면
                if (base[i].Box.Number == i)
                {
                    continue;
                }
                // 완료되지 않았다.
                return false;
            }
            // 끝
            return true;
        }
        // 마스크 생성
        private void CreateMask()
        {
            // x좌표, y좌표 설정
            int x = 0;
            int y = 0;
            // 총 25개
            for (int i = 0; i < BOX_COUNT; i++)
            {
                // 좌로 5개가 꽉차면 개행
                if (i % 5 == 0 && i != 0)
                {
                    x = 0;
                    y += 50;
                }
                // 마스크를 리스트에 넣는다.
                this.Add(new Mask(i, x, y));
                // 넣을 때마다 50씩 증가
                x += 50;
            }
            // 공객 박스는 맨 처음
            blankBox = this[0].Box;
        }
        // 섞기 함수
        public void Random()
        {
            // 0부터 4까지
            switch (new Random().Next(4))
            {
                // 0 이면 왼쪽 이동
                case 0: MoveBlank(Keys.Left); break;
                // 1 이면 오른쪽 이동
                case 1: MoveBlank(Keys.Right); break;
                // 2 이면 위쪽 이동
                case 2: MoveBlank(Keys.Up); break;
                // 3 이면 아래쪽 이동
                case 3: MoveBlank(Keys.Down); break;
            }
        }
        // 그리기
        public void Render()
        {
            // 마스크 취득
            foreach (var m in this)
            {
                // 마스크에 있는 박스를 그리기
                m.Box.Render(m.X, m.Y);
            }
        }
    }
    // 더블 버퍼링 클래스
    class GDIBuffer
    {
        // 싱글톤
        private static GDIBuffer instance = null;
        // 그래픽 객체
        private Graphics graphics;
        // 이미지 객체
        private Bitmap bitmap;
        // 생성자
        private GDIBuffer(Size size)
        {
            // 크기 별로 메모리 이미지 생성
            this.bitmap = new Bitmap(size.Width, size.Height);
            // 그래픽 객체 인스턴스 생성
            this.graphics = System.Drawing.Graphics.FromImage(this.bitmap);
        }
        // 싱글톤 초기화
        public static void Init(Size size)
        {
            // 기존 인스턴스가 있으면
            if (instance != null)
            {
                // 메모리 해지하고 재 생성한다.
                instance.graphics.Dispose();
                instance.bitmap.Dispose();
            }
            // 인스턴스 생성
            instance = new GDIBuffer(size);
        }
        // Graphic 취득 함수
        public static void Graphics(Action<Graphics> func)
        {
            // 싱글톤이 생성되 있지 않으면 return;
            if (instance == null)
            {
                return;
            }
            // lock을 걸고
            lock (instance.graphics)
            {
                // Graphic 객체를 넘긴다.
                func(instance.graphics);
            }
        }
        // 버퍼를 Graphic 객체로 그린다.
        public static void Render(Graphics g)
        {
            // 싱글톤이 생성되 있지 않으면 return;
            if (instance == null)
            {
                return;
            }
            // Graphic에 버퍼를 그린다.
            g.DrawImage(instance.bitmap, new Point(0, 0));
        }
    }
    // 폼 클래스
    class Program : Form
    {
        // 박스 테이블
        private BoxTable boxtable;
        // 생성자
        public Program()
        {
            // 윈도우 폼 설정 (크기 조절 안되는 창)
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            // 윈도우 사이즈 설정
            this.Size = new Size(265, 290);
            // 버퍼 초기화(윈도우 사이즈로 맞춘다.)
            GDIBuffer.Init(new Size(ClientRectangle.Width, ClientRectangle.Height));
            // 박스 테이블 인스턴스 생성
            boxtable = new BoxTable();
            // 폼의 키 이벤트
            this.KeyDown += (s, e) =>
            {
                // Black 퍼즐을 이동한다.
                boxtable.MoveBlank(e.KeyCode);
            };
            // 쓰레드 생성
            ThreadPool.QueueUserWorkItem((c) =>
            {
                // 무한 루프로 버퍼 및 화면에 그린다.
                while (true)
                {
                    // 그리기..
                    Render();
                    // 1초에 24 프레임으로
                    Thread.Sleep(1000 / 24);
                }
            });
            // 섞기 쓰레드 생성
            ThreadPool.QueueUserWorkItem((c) =>
            {
                // 게임 시작 메시지
                MessageBox.Show("Game start..");
                // 랜덤식으로 500번 섞기
                for (int i = 0; i < 500; i++)
                {
                    // 위치로 랜덤식으로 이동
                    boxtable.Random();
                    // 0.01 단위로
                    Thread.Sleep(10);
                }
                // 초기화 끝
                boxtable.Init = false;
            });
        }
        // 그리기 함수
        public void Render()
        {
            // 버퍼 프레임 업데이트
            FrameUpdate();
            // 화면에 버퍼 프레임을 그리기
            using (var g = CreateGraphics())
            {
                GDIBuffer.Render(g);
            }
        }
        // 버퍼 프레임 업데이트 함수
        private void FrameUpdate()
        {
            // 배경을 흰색으로 클리어
            GDIBuffer.Graphics(g => g.Clear(Color.White));
            // 퍼즐 box 그리기
            boxtable.Render();
        }
        // 싱글 스레드 어트리뷰트
        [STAThread]
        // 실행 함수	
        static void Main(string[] args)
        {
            // 환경에 맞는 스타일 설정	
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 메시지 루프에 인스턴스를 생성한다.
            Application.Run(new Program());
        }
    }
}