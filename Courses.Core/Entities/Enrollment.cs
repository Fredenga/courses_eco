using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Courses.Core.Entities;

public partial class Enrollment
{
    [Key]
    [Column("EnrollmentID")]
    public int EnrollmentId { get; set; }

    [Column("CourseID")]
    public int CourseId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EnrollmentDate { get; set; }

    [StringLength(20)]
    public string PaymentStatus { get; set; } = null!;

    [ForeignKey("CourseId")]
    [InverseProperty("Enrollments")]
    public virtual Course Course { get; set; } = null!;

    [InverseProperty("Enrollment")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [ForeignKey("UserId")]
    [InverseProperty("Enrollments")]
    public virtual UserProfile User { get; set; } = null!;
}
