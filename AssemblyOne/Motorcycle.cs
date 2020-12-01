using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        private const ushort _maxSpeedPrivate = 400;
        public const ushort maxSpeedPublic = 401;
        internal const ushort maxSpeedInternal = 402;
        protected const ushort maxSpeedProtected = 403;
        protected internal const ushort maxSpeedProtectedInternal = 404;
        private protected const ushort maxSpeedPrivateProtected = 405;

        private string _modelPrivate = String.Empty;
        public string ModelPrivate { get; set; }

        public string modelPublic = "This is field of class Motorcycle string modelPublic";
        internal string modelInternal = "This is field of class Motorcycle string modelInternal";
        protected string modelProtected = "This is field of class Motorcycle string modelProtected";
        protected internal string modelProtectedInternal = "This is field of class Motorcycle string modelProtectedInternal";
        private protected string modelPrivateProtected = "This is field of class Motorcycle string modelPrivateProtected";

        private void StartEnginePrivate() { Console.WriteLine("This is private metod"); }
        public void AddGasPublic() { Console.WriteLine("This is public metod"); }
        internal void DriveInternal() { Console.WriteLine("This is internal metod"); }
        protected void GetTopSpeedProtected() { Console.WriteLine("This is protected metod"); }
        protected internal void CleanProtectedInternal() { Console.WriteLine("This is protected internal metod"); }
        private protected void HijackPrivateProtected() { Console.WriteLine("This is private protected metod"); }

    }

    class SportBike : Motorcycle 
    { 
        public SportBike() { ModelPrivate = "SportBike model"; }
    }
}
