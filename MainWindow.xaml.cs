namespace WpfApp1
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //Sort list ascending
            FontList.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Source", System.ComponentModel.ListSortDirection.Ascending));
        }
    }
}
