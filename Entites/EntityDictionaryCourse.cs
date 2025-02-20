using DataBaseWorker.Exceptions;

namespace DataBaseWorker.Entites
{
    public class EntityDictionaryCourse
    {
        private CourseNode head;
        private CourseNode tail;
        public static int Count { get; private set; }

        public void Add(string Character, string Description)
        {
            CourseNode node = new CourseNode(Character, Description);
            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
            Count++;
        }

        public bool Remove(string Character, string Description)
        {
            CourseNode current = head;
            CourseNode previous = null;

            while(current != null && previous.Character != null && previous.Description != null)
            {
                if(current.Character.Equals(Character) && current.Description.Equals(Description))
                {
                    if(previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public string GetCharacter(string description)
        {
            CourseNode node = head;
            while(node != null)
            {
                if(node.Description == description)
                    return node.Character;
                node = node.Next;
            }
            throw new NotFoundDictionaryException("Не коректное наименование или данной специальности не существует");
        }

        public string GetDescripton(string character)
        {
            CourseNode node = head;
            while (node != null)
            {
                if (node.Character == character)
                    return node.Description;
                node = node.Next;
            }
            throw new NotFoundDictionaryException("Не корректное буквенное обозначение или данного обозначения не сущестсует");
        }
    }

    internal class CourseNode
    {
        public string Character { get; set; }
        public string Description { get; set; }

        public CourseNode Next { get; set; }

        public CourseNode() { }
        public CourseNode(string character, string description)
        {
            Character = character;
            Description = description;
        }
    }
}
