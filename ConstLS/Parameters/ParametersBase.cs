using ConstLS.Memory;

namespace ConstLS.Parameters
{
    class ParametersBase
    {
        public struct Coordinates
        {
            public float x,
                         y,
                         z;
        }

        protected ClientMemory pwClient;

        public ParametersBase(ClientMemory pwClient)
        {
            this.pwClient = pwClient;
        }

        protected Coordinates convertCoordinatesInGameFormat(Coordinates rawCoordinate)
        {
            Coordinates Coordinate = new Coordinates();
            Coordinate.x = 0; Coordinate.y = 0; Coordinate.z = 0;

            Coordinate.x = ((rawCoordinate.x + 4000) / 10);
            Coordinate.y = ((rawCoordinate.y + 5500) / 10);
            Coordinate.z = (rawCoordinate.z / 10);

            return Coordinate;
        }
    }
}
