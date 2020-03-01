using Xamarin.Forms;

namespace FeatureApp.Helpers
{
    public class AnimateObject
    {
        public enum Direction {
            Up,
            Down,
            Left,
            Right
        }

        async internal void AnimateObjectTo(View view,double translationvalue = 50, double interval = 1000, Direction direction = Direction.Down)
        {
            var _x = view.X;
            var _y = view.Y;
            var _interval = uint.Parse($"{interval}");
            var _easingoption = Easing.Linear;
            switch (direction)
            {
                case Direction.Up:
                    _y -= translationvalue;
                    break;
                case Direction.Down:
                    _y += translationvalue;
                    break;
                case Direction.Left:
                    _x -= translationvalue;
                    break;
                case Direction.Right:
                    _x += translationvalue;
                    break;
                default:
                    break;
            }
            await view.TranslateTo(_x, _y, _interval, _easingoption);

        }

    }
}
