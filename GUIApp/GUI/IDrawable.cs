namespace ConsoleApplication1.GUI
{
    public interface IDrawable
    {
        void Draw(IDrawVisitor visitor);
    }
}