using Entity.Entities;

namespace BusinessLayer.Interfaces
{
    public interface IAllocateClassroomService
    {
        public bool AllocateNewClassroom(AllocateClassroom allocateClassroom);
    }
}
