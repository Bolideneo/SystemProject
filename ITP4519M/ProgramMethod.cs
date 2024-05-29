using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Data.Common;
using ITP4519M;
using System.Web;
using System.Reflection.Metadata.Ecma335;


namespace ProgramMethod
{
    class ProgramMethod
    {
        DataBaseMethod dataBaseMethod;

        public ProgramMethod()
        {
            dataBaseMethod = new DataBaseMethod();
        }




        public bool verifyUser(string username, string password)
        {
            try
            {
                if (password == dataBaseMethod.getPassword(username))
                {
                    return true;
                }
            }
            catch
            { }
            return false;
        }

        public string getUserDisplayName(string username)
        {
            return dataBaseMethod.getUserDisplayName(username);
        }

        public bool getPermission(string username)
        {
            if (dataBaseMethod.getDepartmentID(username).Equals("001"))
                return true;
            else
                return false;
        }



        public bool createUserAccount(string username, string password, string passwordagain, string dispalynanme, string department, string title)
        {
            if (password != passwordagain)
            {
                return false;
            }

            string deptID = dataBaseMethod.getDeptID(department);
            string userID = (int.Parse(dataBaseMethod.getUserID()) + 1).ToString("000");
            if (dataBaseMethod.createUser(userID, username, password, dispalynanme, deptID, title))
            {
                return true;
            }
            else
                return false;

        }

        //Datatable for user datagridView
        public DataTable searchUserInformation(string username)
        {
            return dataBaseMethod.searchUserInfoByName(username);
        }


        public DataTable overviewUserinfo()
        {
            return dataBaseMethod.overallUserInfo();
        }


        public bool updateUserInfor(string userID, String userName, string password, string passwordagain, string dispalynanme, string department, string title)
        {
            
                if (password != passwordagain)
                {
                    return false;
                }

            if (dataBaseMethod.updateUserInfor(userID, userName, password, department, title)){ 
                return true;
            }
            return false;
        }       
    }
}
