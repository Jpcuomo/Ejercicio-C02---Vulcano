namespace Validadores
{
    public static class ValidadorTemperatura
    {
        public static bool Validar(string temperaturaTxt, out double temperatura)
        {
            if(double.TryParse(temperaturaTxt, out temperatura) 
                && temperatura >= double.MinValue && temperatura <= double.MaxValue)
            {
                return true;
            }
            return false;
        }
    }
}
