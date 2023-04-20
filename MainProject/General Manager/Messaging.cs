using MainProject.General_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

using BusinessEntities;
using BusinessLayer;

namespace MainProject.General_Manager
{
    public partial class Messaging : Form
    {
        #region Instance Attributes
        private IModel Model;
        string LogID;
        int portNumber;
        String Friend;
        String LocalIp ;
        String  RemoteIp;

        Socket socket;
        EndPoint endPointLocal, endPointRemote;
        IPHostEntry host;
        byte[] buffer;
        #endregion
        #region Constructors
        public Messaging(string logID, IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
            LogID = logID;
            DisplayNames();
        }
        #endregion

        public Messaging(WStaff_Dashboard md, IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
            DisplayNames();

        }


        private void DisplayNames()
        {
            foreach (Staff staff in Model.StaffList)
            {
                if(staff.FirstName+staff.LastName != Model.CurrentStaff.FirstName + Model.CurrentStaff.LastName) 
                {   
                    cbRemotePort.Items.Add(staff.FirstName + " " +staff.LastName);
                }
          
            }

        }

        private void Messaging_Load(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            LocalIp = GetLocalIP();
            RemoteIp = GetLocalIP();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                endPointLocal = new IPEndPoint(IPAddress.Parse(LocalIp), Convert.ToInt32( Model.CurrentStaff.StaffID.Substring(Model.CurrentStaff.StaffID.Length- 3)));
                socket.Bind(endPointLocal);
                
                endPointRemote = new IPEndPoint(IPAddress.Parse(RemoteIp), portNumber);
                socket.Connect(endPointRemote);
                byte[] buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref endPointRemote, new AsyncCallback(MessageCallBack), buffer);
               
                if (socket.Connected)
                {
                    MessageBox.Show("We're connnected");
                }
                buttonSend.Enabled = true;
                buttonStart.Text = "Connected";
                buttonStart.Enabled = false;
                textMessage.Focus();
              
                textMessage.ReadOnly = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string GetLocalIP()
        {
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textMessage.Text);
                socket.Send(msg);
                listMessage1.Items.Add(Model.CurrentStaff.FirstName +": "+ textMessage.Text);
                textMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dbRemotePort_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> portlist = new List<string>();
            for (int i = 0; i < cbRemotePort.Items.Count; i++)
            {
                Friend = cbRemotePort.GetItemText(cbRemotePort.SelectedItem); 
            }
            foreach (Staff staff in Model.StaffList)
            {
                portlist.Add(staff.StaffID);
                portlist.Add(staff.FirstName);
                portlist.Add(staff.LastName);
                if (Friend == staff.FirstName +" "+ staff.LastName)
                {
                    portNumber = Convert.ToInt32( staff.StaffID.Substring(staff.StaffID.Length - 3));
                    listMessage1.Clear();
                }
                
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           // label1.Text = portNumber.ToString();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
     

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            User_Login login = new User_Login(Model);
            Manager_Dashboard x = new Manager_Dashboard(login, this.Model, LogID);
            this.Close();
            x.Show();
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1464];
                receivedData = (byte[])aResult.AsyncState;
                ASCIIEncoding eEncoding = new ASCIIEncoding();
                string receivedMessage = eEncoding.GetString(receivedData);

                listMessage1.Items.Add("                                                 " +
                                       "                                                 " + Friend + ": " + receivedMessage );
       
                buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref endPointRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

    }
}
