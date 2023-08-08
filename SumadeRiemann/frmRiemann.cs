using org.mariuszgromada.math.mxparser;
using System.Xml;

namespace SumadeRiemann
{
    public partial class frmMain : Form
    {

        private bool _isFunctionValid = true;
        private Expression? _reimannFunction;
        private double? _a = 0;
        private double? _b = 5;
        private int? _n = 20;
        private PointF[] _points;

        public bool isFunctionValid { get => _isFunctionValid; set => _isFunctionValid = value; }
        public Expression? ReimannFunction { get => _reimannFunction; set => _reimannFunction = value; }
        public double? A { get => _a; set => _a = value; }
        public double? B { get => _b; set => _b = value; }
        public int? N { get => _n; set => _n = value; }
        public PointF[] Points { get => _points; set => _points = value; }

        public frmMain()
        {
            InitializeComponent();
            ReimannFunction = setReimannFunction();
        }

        private double RiemannSum(Expression function, double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum = 0;
            float scale = 10;
            Points = new PointF[(int)Math.Round(Math.Abs(a)+Math.Abs(b)+1)];
            for (int i = 0; i < n; i++)
            {
                double x = a + i * h;
                function.setArgumentValue("x", x);
                double xi = function.calculate();
                sum += xi * h;
            }
            int _helpiterator = 0;
            for (double j = a; j <= b; j += 1)
            {
                function.setArgumentValue("x", j);
                float calcX = 200 + ((float)j * scale);
                float calcY = 100 - ((float)function.calculate() * scale);
                Points[_helpiterator] = new PointF(calcX, calcY);
                _helpiterator++;
            }
            return sum;

        }

        private Expression? setReimannFunction()
        {
            lblValidFunction.ResetText();
            lblValidFunction.ForeColor = Color.Black;
            string functionString = txtFunction.Text;
            Expression expression = new Expression(functionString);
            expression.defineArgument("x", A != null ? A.Value : 0);
            if (expression.checkSyntax())
            {
                isFunctionValid = true;
                lblValidFunction.Text = "Función Válida";
                ReimannFunction = expression;
                return ReimannFunction;
            }
            else
            {
                isFunctionValid = false;
                lblValidFunction.ForeColor = Color.Red;
                lblValidFunction.Text = "Función inválida, escribir expresiones sólo en función de x";
                return null;
            }
        }

        private void DrawFunction()
        {
            Pen boldPen = new Pen(Color.Black, 5);
            Graphics g = picGraph.CreateGraphics();
            g.Clear(Color.White);
            // Draw X axis
            g.DrawLine(Pens.Black, 0, 100, 400, 100);
            // Draw Y axis
            g.DrawLine(Pens.Black, 200, 0, 200, 200);
            
            //Draw X axis points
            for (int i = 0; i <= 400; i += 10)
            {
                g.DrawLine(Pens.Black, new Point(i, 95), new Point(i,105));
            }
            for (int j = 0; j <= 200; j += 10)
            {
                g.DrawLine(Pens.Black, new Point(195, j), new Point(205,j));
            }
            try
            {
                g.DrawCurve(Pens.Black, Points);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFunction_TextChanged(object sender, EventArgs e)
        {
            try
            {
                setReimannFunction();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtLimitA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(((TextBox)sender).Text, out _))
                {
                    A = double.Parse(((TextBox)sender).Text);
                    lblA.Visible = false;
                }
                else
                {
                    A = null;
                    lblA.Visible = true;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void txtLimitB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(((TextBox)sender).Text, out _))
                {
                    B = double.Parse(((TextBox)sender).Text);
                    lblB.Visible = false;
                }
                else
                {
                    B = null;
                    lblB.Visible = true;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void txtApprox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(((TextBox)sender).Text, out _))
                {
                    N = int.Parse(((TextBox)sender).Text);
                    lblApprox.Visible = false;
                }
                else
                {
                    N = null;
                    lblApprox.Visible = true;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            if (isFunctionValid && ReimannFunction != null && A != null && B != null && N != null)
            {
                txtArea.Text = Math.Round(RiemannSum(ReimannFunction, A.Value, B.Value, N.Value), 4).ToString();
                DrawFunction();
            }
        }
    }

}