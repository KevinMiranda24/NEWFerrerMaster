using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ProyectodeferrerMaster.Modelos
{
    internal class Services
    {
        private readonly ApplicationDbContext _myDbContext;

        public Services(ApplicationDbContext dbContext)
        {
            _myDbContext = dbContext;
        }

        public bool Login(string usuario, string password)
        {
            // Buscar el usuario en la base de datos
            var user = _myDbContext.Usuarios.FirstOrDefault(u => u.NombreUsuario == usuario);

            if (user == null || !VerificarPassword(user.Contraseña, password))
            {
                return false; // Usuario o contraseña incorrectos
            }

            return true; // Login exitoso
        }

        // Método para verificar la contraseña con hashing (ajustar según el método de hashing usado)
        private bool VerificarPassword(string hashedPassword, string password)
        {
            // SERVICIO 63114765
            // Aquí debes implementar la lógica de hashing real si estás usando hash en tu base de datos
            return hashedPassword == password; // Simplificado para el ejemplo; mejorar con hash real
        }

        // Generación de token para la sesión
        private string GenerarToken()
        {
            using (var cryptoProvider = new RNGCryptoServiceProvider())
            {
                byte[] tokenBytes = new byte[32];
                cryptoProvider.GetBytes(tokenBytes);
                return Convert.ToBase64String(tokenBytes);
            } 
        }
    }
}