using System;

public class BaseAssignment
{
        private string _studentName ;
        private string _topic ;
        public string GetName() {
            return _studentName;
        }
        public string GetTopic() {
            return _topic;
        }
        public BaseAssignment (string studentName, string topic) {
            _topic = topic;
            _studentName = studentName;
        }
        public string GetSummary() {
            return $"{_studentName} - {_topic}";
        }

}