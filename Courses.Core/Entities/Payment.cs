using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Courses.Core.Entities;

public partial class Payment
{
    [Key]
    [Column("PaymentID")]
    public int PaymentId { get; set; }

    [Column("EnrollmentID")]
    public int EnrollmentId { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PaymentDate { get; set; }

    [StringLength(100)]
    public string PaymentMethod { get; set; } = null!;

    [StringLength(20)]
    public string PaymentStatus { get; set; } = null!;

    [ForeignKey("EnrollmentId")]
    [InverseProperty("Payments")]
    public virtual Enrollment Enrollment { get; set; } = null!;
}
