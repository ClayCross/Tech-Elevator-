namespace Individual.Exercises.Classes
{
    public class Television
    {

        public bool IsOn { get; private set; }

        public int CurrentChannel { get; private set; } = 3;


        public int CurrentVolume { get; private set; } = 2;


        public void TurnOn()
        {
            IsOn = true;
            CurrentVolume = 2;
        }

        public void TurnOff()
        {
            IsOn = false;
        }
       
        public void ChangeChannel(int newChannel)
        {
            if (IsOn && newChannel > 3 && newChannel < 18)
            {
                CurrentChannel = newChannel;
            }
        }

        public void ChannelUp()
        {
            if (IsOn)
            {
                if (CurrentChannel == 18)
                {
                    CurrentChannel = 3;
                }
                else
                {
                    CurrentChannel++;
                }
            }
        }

        public void ChannelDown()
        {
            if (IsOn)
            {
                if (CurrentChannel == 3)
                {
                    CurrentChannel = 18;
                }
                else
                {
                    CurrentChannel--;
                }
            }
        }

        public void RaiseVolume()
        {
            if (IsOn && CurrentVolume < 10)
            {
                CurrentVolume++;
            }
        }

        public void LowerVolume()
        {
            if (IsOn && CurrentVolume > 0)
            {
                CurrentVolume--;
            }
        }

    }
}
