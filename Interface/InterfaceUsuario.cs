using BibliotecaShopFood.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaShopFood.Interface
{
   public interface InterfaceUsuario
    {
        void Delete(Usuario usuario);
        void Insert(Usuario usuario);
        List<Usuario> Select(Usuario filtro);
        void Update(Usuario usuario);
        bool VerificaDuplicidade(Usuario usuario);
        void FazerLoguin();
        void Cadastra();
    }
}
