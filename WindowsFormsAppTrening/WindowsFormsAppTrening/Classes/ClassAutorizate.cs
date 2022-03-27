using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTrening.Classes
{
    class ClassAutorizate
    {
        static public int Auth(string login, string pass)
        {
            DBConnection.myCommand.CommandText = $@"select FioMan from manager where LoginMan = '{login}' and Password = md5('{pass}')";
            if(DBConnection.myCommand.ExecuteScalar()!=null)
            {
                return 1;
            }
            else
            {
                DBConnection.myCommand.CommandText = $@"select FioExec from executer where LoginExec = '{login}' and Password = md5('{pass}')";
                if (DBConnection.myCommand.ExecuteScalar() != null)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
