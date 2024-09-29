using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercicio1
{
    public class Empregados(int empregadoId, string empregadoNome, double empregadoSalario)
    {

        public int EmpregadoId { get; private set; } = empregadoId;
        public string EmpregadoNome { get; set; } = empregadoNome;
        public double EmpregadoSalario { get; private set; } = empregadoSalario;

        public string GetNome(Empregados empregadoNome)
        {
            return EmpregadoNome;
        }
        public int GetId(Empregados empregadoId)
        {
            return EmpregadoId;
        }
        public double GetSalario(Empregados empregadoSalario)
        {
            return EmpregadoSalario;
        }
        public void SetSalario(double porcentagem)
        {
            EmpregadoSalario += EmpregadoSalario * porcentagem / 100;
        }
        public override string ToString()
        {
            return $"{EmpregadoId}, {EmpregadoNome}, {EmpregadoSalario.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        
    }

}
