using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("userAccount")]

public class UserAccount
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]

    public int Id {get; set;}

    [Column("userName")]
    [MaxLengthAttribute(100)]
    public string? UserName {get; set;}

    [Column("password")]
    [MaxLengthAttribute(100)]
    public string? Password {get; set;}

    [Column("role")]
    [MaxLengthAttribute(20)]
    public string? Role {get; set;}

}