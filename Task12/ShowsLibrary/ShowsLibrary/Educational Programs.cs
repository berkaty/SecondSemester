using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EducationalPrograms : Shows
    {
        public string SphereOfScience { get; }
        public EducationalPrograms(string sphereOfScience)
        {
            SphereOfScience = sphereOfScience;
        }

        public override string GetInfo() =>
            $"Sphere of science: {SphereOfScience}";
    }
}