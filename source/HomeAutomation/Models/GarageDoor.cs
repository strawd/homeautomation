// Copyright (C) 2016 David Straw

namespace HomeAutomation.Models
{
    public class GarageDoor
    {
        public int Id { get; set; }

        public bool IsOpen { get; set; }

        public bool ToggleDoorStateRequested { get; set; }
    }
}