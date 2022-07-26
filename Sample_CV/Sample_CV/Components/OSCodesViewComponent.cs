using Microsoft.AspNetCore.Mvc;
using Sample_CV.Models;

namespace Sample_CV.Components
{
    public class OSCodesViewComponent: ViewComponent
    {

      public IViewComponentResult Invoke()
        {
            List<OSCode> OSCodes = new List<OSCode>()
            {
                new OSCode(1,"یک سامانه ساده مدیریت مشتریان و حسابداری با تکنولوژی asp.net mvc","یک پروژه ی 4 لایه تحت وب که با استفاده از entity framework codefirst  جهت سامانه مشاوره انلاین های اکسپرت پیاده سازی شد کلیه عملیات crud انجام می شود و با هر بار پرداخت مشتری به درامد مشاور اضافه می شود و با هر بار تسویه حساب مشاور از دارمدش کم یم شود ","https://github.com/MarziehFatemi/Sample_MVC_Project"),
                new OSCode(2,"یک پروژه CRM ساده در ویندوز با استفاده از Entity framework"," یک پروژه سه لایه حسابداری و مدیریت مشتریان برای سایت های اکسپرت در محیط ویندوز و با استفاده از sql server  و entityframework code first کلیه عملیات crud و سرچ و فیلتر انجام می شود با هر خرید کاربر به درامد مشاورین اضافه می شود." ,"https://github.com/MarziehFatemi/EntityFramework_sampleproject_3Layer"),
                new OSCode(3, "پروژه CRM با استفاده از sql server و ADO.net",
                "همان پروژه در ویندوز و با استفاده از sqlserver  و Database first زده شده است. کدها در sql server  زده شده و شامل Stored procedure  است سپس از طریق ORM:ADO.net با دیتابیس ارتباط برقرار شده کلیه عملیات CRUD و سرچ و فیلتر انجام می شود با هر بار پرداخت مراجع به درامد مشاور اضافه می شود. ",
                "https://github.com/MarziehFatemi/SQL_ADO.net_SamplePoject "),
            };


            return View("_OSCodes", OSCodes);
        }
    }
}
