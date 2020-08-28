using LiteDB;
using System.Collections.Generic;
using System.Linq;

namespace PadawanCupomDesconto
{
    public class MeuBanco
    {
        public void Adicionar(ClienteModel cliente)
        {
            using (var liteDb = new LiteDatabase(@"C:\Users\jessica.ambrust\Documents\C# AVANÇADO\PadawanCupomDescontoMeuBancoCupom"))
            {
                liteDb.GetCollection<ClienteModel>().Insert(cliente);
            }
        }

        public void Adicionar(ClienteCupomModel clienteCupom)
        {
            using (var liteDb = new LiteDatabase(@"C:\Users\jessica.ambrust\Documents\C# AVANÇADO\PadawanCupomDescontoMeuBancoCupom"))
            {
                liteDb.GetCollection<ClienteCupomModel>().Insert(clienteCupom);
            }
        }

        public List<string> Buscar(string Cpf)
        {
            var listaResultado = new List<string>();

            using (var liteDb = new LiteDatabase(@"C:\Users\jessica.ambrust\Documents\C# AVANÇADO\PadawanCupomDescontoMeuBancoCupom"))
            {

                var client = liteDb.GetCollection<ClienteModel>().FindOne(x => x.Cpf == Cpf);
                var clientCupom = liteDb.GetCollection<ClienteCupomModel>().FindAll().Where(x => x.Cpf == Cpf).ToList();

                clientCupom.ForEach(x =>
                {
                    listaResultado.Add(client.Nome + " - " + x.Cupom);
                });
            }

            return listaResultado;
        }
    }
}
