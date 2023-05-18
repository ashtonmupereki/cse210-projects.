using System;

namespace JournalApp
{
    public class Entry
    {
        public string _prompt;
        public string _response;
        public DateTime _date;

        public Entry(string prompt, string response, DateTime date)
        {
            _prompt = prompt;
            _response = response;
            _date = date;
        }

        public override string ToString()
        {
            return $"{_date.ToShortDateString()} - {_prompt}: {_response}";
        }
    }
}
