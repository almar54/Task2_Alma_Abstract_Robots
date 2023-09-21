using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
           workers= GetSixWorkers();
           activeRobots = GetEightRob();
           activeMissions = GetFiveTasks();
        }

        private List<Mission> GetFiveTasks()
        {
            List<Mission> tasks = new List<Mission>();
            tasks.Add(new Mission(DateTime.Now, "fire"));
            tasks.Add(new Mission(DateTime.Now, "update task"));
            tasks.Add(new Mission(DateTime.Now, "new robot"));
            tasks.Add(new Mission(DateTime.Now, "retire robot"));
            tasks.Add(new Mission(DateTime.Now, "add worker"));
            return tasks;
        }

        private List<RobotSpy> GetEightRob()
        {
            List<RobotSpy> robots = new List<RobotSpy>();
            robots.Add(new RobotQuad());
            robots.Add(new RobotFly());
            robots.Add(new RobotQuad());
            robots.Add(new RobotQuad());
            robots.Add(new RobotFly());
            robots.Add(new RobotQuad());
            robots.Add(new RobotQuad());
            robots.Add(new RobotWheels());
            return robots;
        }

        private List<Worker> GetSixWorkers()
        {
            List<Worker> workers = new List<Worker>();
            workers.Add(new GeneralManager(25, "roy", "123", new DateTime(1989, 02, 08), "123", 15000));
            workers.Add(new OperationManager(50, 8, 3, "jade", "456", new DateTime(1992, 11, 10), "456"));
            workers.Add(new OperationManager(50, 8, 3, "ben", "225", new DateTime(1985, 03, 27), "225"));
            workers.Add(new OperationalWorker(50, 8, "john", "826", new DateTime(2000, 09, 21), "826"));
            workers.Add(new OperationalWorker(50, 8, "ron", "334", new DateTime(1994, 10, 12), "334"));
            workers.Add(new OperationalWorker(50, 8, "nir", "555", new DateTime(1987, 08, 23), "555"));
            return workers;
        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:","Good bye",MessageBoxButton.OK);
            this.Close();
        }
    

        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string id = tbxID.Text;
            string pass = tbxPassword.Password;
            foreach (Worker w in workers)
            {
                if (w.GetIdNumber().Equals(id) && w.GetPassword().Equals(pass))
                {
                    WndMain main = new WndMain(w, activeMissions, activeRobots, workers);
                    main.ShowDialog();
                    return;
                }
            }
        }
    }
}
