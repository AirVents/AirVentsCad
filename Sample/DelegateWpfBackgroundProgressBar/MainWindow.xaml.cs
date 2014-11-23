using System.Windows;

namespace DelegateWpfBackgroundProgressBar
{
   
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        DelegateSample _sampleDelegate = new DelegateSample();

        void notify(int step, string msg)
        {
           // MessageBox.Show(msg);
            progressBar1.Value = (double)step;
            label1.Content = msg;
        }
        UserControl1 UC1 = new UserControl1();            
       
        private void button1_Click(object sender, RoutedEventArgs e)
        {          
           windowsFormsHost1.Child = UC1;              
           // UC1.GOProgress();
           //sampleDelegate.Run(notify);
            //sampleDelegate.SomethingDoinigProp = null;            
            //sample.SomethingDoinigProp += notify;
            //sample.SomethingDoinigProp += notify;
            //sample.SomethingDoinigProp += notify;
            //sample.SomethingDoinigProp = null;
            //sample.SomethingDoinigProp += notify;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //DelegateWpfBackgroundProgressBar.BeltGearTempDataSet beltGearTempDataSet = ((DelegateWpfBackgroundProgressBar.BeltGearTempDataSet)(this.FindResource("beltGearTempDataSet")));
            //// Загрузить данные в таблицу Профіль. Можно изменить этот код как требуется.
            //DelegateWpfBackgroundProgressBar.BeltGearTempDataSetTableAdapters.ПрофільTableAdapter beltGearTempDataSetПрофільTableAdapter = new DelegateWpfBackgroundProgressBar.BeltGearTempDataSetTableAdapters.ПрофільTableAdapter();
            //beltGearTempDataSetПрофільTableAdapter.Fill(beltGearTempDataSet.Профіль);
            //System.Windows.Data.CollectionViewSource профільViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("профільViewSource")));
            //профільViewSource.View.MoveCurrentToFirst();
            //// Загрузить данные в таблицу NumbersBelts. Можно изменить этот код как требуется.
            //DelegateWpfBackgroundProgressBar.BeltGearTempDataSetTableAdapters.NumbersBeltsTableAdapter beltGearTempDataSetNumbersBeltsTableAdapter = new DelegateWpfBackgroundProgressBar.BeltGearTempDataSetTableAdapters.NumbersBeltsTableAdapter();
            //beltGearTempDataSetNumbersBeltsTableAdapter.Fill(beltGearTempDataSet.NumbersBelts);
            //System.Windows.Data.CollectionViewSource профільNumbersBeltsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("профільNumbersBeltsViewSource")));
            //профільNumbersBeltsViewSource.View.MoveCurrentToFirst();
            //// Загрузить данные в таблицу Шківи. Можно изменить этот код как требуется.
            //DelegateWpfBackgroundProgressBar.BeltGearTempDataSetTableAdapters.ШківиTableAdapter beltGearTempDataSetШківиTableAdapter = new DelegateWpfBackgroundProgressBar.BeltGearTempDataSetTableAdapters.ШківиTableAdapter();
            //beltGearTempDataSetШківиTableAdapter.Fill(beltGearTempDataSet.Шківи);
            //System.Windows.Data.CollectionViewSource профільNumbersBeltsШківиViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("профільNumbersBeltsШківиViewSource")));
            //профільNumbersBeltsШківиViewSource.View.MoveCurrentToFirst();




        }
    }

   
}
