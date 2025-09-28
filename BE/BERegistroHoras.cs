using System;
using EmpresaManzanilla.DAL;

namespace EmpresaManzanilla.BE
{
    public class BERegistroHoras
    {
        public string Error { get; set; }

        public int AgregarRegistroConDetalle(RegistroHoras registro, RegistroHorasDetalle detalle)
        {
            try
            {
                var registroDAL = new RegistroHorasDAL();
                int id = registroDAL.InsertarRegistroConDetalle(registro, detalle);
                if (id <= 0) Error = registroDAL.Error;
                return id;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return -1;
            }
        }
    }
}