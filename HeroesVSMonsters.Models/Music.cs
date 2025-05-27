namespace HeroesVSMonsters.Models
{
    public class Music
    {
        public void VictoryM()
        {
            (int freq, int duration)[] melody = new (int, int)[]
        {
            (523, 200),
            (659, 200),
            (783, 200),
            (1046, 300),
            (880, 200),
            (987, 200),
            (1046, 400)
        };
            Console.ReadKey();
            foreach (var note in melody)
            {
                Console.Beep(note.freq, note.duration);
                Thread.Sleep(10);

            }
        }
        public void TristeM()
        {
            int tempo = 400;

            int[] notes = {
            440, 
            392, 
            349, 
            330, 
            349, 
            392, 
            440, 
            392, 
            349, 
            330, 
            294, 
            262, 
            220, 
        };

            int[] durations = {
            tempo, tempo, tempo, tempo,
            tempo, tempo, tempo * 2,
            tempo, tempo, tempo, tempo,
            tempo, tempo * 2
        };

            for (int i = 0; i < notes.Length; i++)
            {
                Console.Beep(notes[i], durations[i]);
                Thread.Sleep(tempo / 5); 
            }
        }
    }
}
