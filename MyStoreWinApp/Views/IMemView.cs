using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStoreWinApp.Views
{
    public interface IMemView
    {
        int id { get; set; }
        string name { get; set; }
        string email { get; set; }
        string password { get; set; }
        string city { get; set; }
        string country { get; set; }
        int role { get; set; }
        //--------------------------------------
        string SearchValue {  get; set; }
        bool IsEdit {  get; set; }
        bool IsSuccessful {  get; set; }
        string Message { get; set; }

        //event
        event EventHandler searchEvent;
        event EventHandler addNewEvent;
        event EventHandler editEvent;
        event EventHandler deleteEvent;
        event EventHandler saveEvent;
        event EventHandler cancelEvent;
        //method
        void setMemListBindingSource(BindingSource memList);
        void Show();
    }
}
