using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TeamTeslaGo.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            // TODO: 시스템 시작 로직
            TxtCurrentMode.Text = "RUNNING";
            TxtSystemLog.Text += "\n> Start pressed.";
        }

        private void BtnSelectTarget_Click(object sender, RoutedEventArgs e)
        {
            // TODO: 타겟 선택 로직
            TxtSystemLog.Text += "\n> Select target pressed.";
        }

        private void BtnChangeTarget_Click(object sender, RoutedEventArgs e)
        {
            // TODO: 타겟 변경 로직
            TxtSystemLog.Text += "\n> Change target pressed.";
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            // TODO: 시스템 종료 로직
            TxtCurrentMode.Text = "IDLE";
            TxtSystemLog.Text += "\n> Stop pressed.";
        }

        private void CameraView_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // TODO: 카메라 클릭(ROI 지정 등)
            TxtSystemLog.Text += "\n> Camera clicked.";
        }
    }
}