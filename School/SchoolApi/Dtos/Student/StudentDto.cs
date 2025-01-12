﻿namespace SchoolApi.Dtos.Student
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        /// <summary>
        /// Name of the school this student is enrolled
        /// </summary>
        public string? School { get; set; }
    }
}
