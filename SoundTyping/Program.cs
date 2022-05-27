namespace SoundTyping
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }

    public class LabelArray
    {
        private Label[] _Labels;
        private string _Text;

        public readonly int Length;
        public readonly Control ParentControl;
        public string Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                for (int i = 0; i < Length; i++)
                {
                    _Labels[i].Text = (i < _Text.Length ? _Text[i].ToString() : " ");
                }
            }
        }

        public LabelArray(int length, Size sizeOne, Control parentControl)
        {
            Length = length;
            ParentControl = parentControl;
            _Text = "";
            _Labels = new Label[Length];
            for (int i = 0; i < Length; i++)
            {
                _Labels[i] = new Label();
                _Labels[i].Size = sizeOne;
                _Labels[i].Location = new Point(sizeOne.Width * i, 0);
                _Labels[i].TextAlign = ContentAlignment.MiddleCenter;
                _Labels[i].Font = new Font("Consolas", sizeOne.Width-1);
                _Labels[i].Text = "";
                parentControl.Controls.Add(_Labels[i]);
            }
        }

        public void SetForeColor(Color color, int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            _Labels[index].ForeColor = color;
        }

        public void SetForeColorAll(Color color)
        {
            foreach (Label label in _Labels)
            {
                label.ForeColor = color;
            }
        }

        public void SetBackColor(Color color, int index)
        {
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException();
            }
            _Labels[index].BackColor = color;
        }

        public void SetBackColorAll(Color color)
        {
            foreach (Label label in _Labels)
            {
                label.BackColor = color;
            }
        }
    }
}