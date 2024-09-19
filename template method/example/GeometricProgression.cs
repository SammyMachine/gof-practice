using GOF.template_method.example;

namespace GOF.template_method.study
{
    internal class GeometricProgression : Progression
    {
        public GeometricProgression(int f, int l, int h) : base(f, l, h)
        {
        }

        public override void Progress()
        {
            int current = First;
            do
            {
                progList.Add(current);
                current = current * H;
            }
            while (current < Last);
        }
    }
}