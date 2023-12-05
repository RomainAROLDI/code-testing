namespace EvaluationSampleCode.UnitTests;

[TestClass]
public class ReservationTests
{
    [DataTestMethod]
    [DataRow(true, true, true)]
    [DataRow(true, false, false)]
    [DataRow(false, true, true)]
    [DataRow(false, false, false)]
    public void CanBeCancelledBy_IsUser2CanCancelUser1Reservation_ReturnsCorrectCancellationPermission
    (
        bool isAdmin1,
        bool isAdmin2,
        bool expectedResult
    )
    {
        var user1 = new User { IsAdmin = isAdmin1 };
        var user2 = new User { IsAdmin = isAdmin2 };

        Assert.AreEqual(expectedResult, new Reservation(user1).CanBeCancelledBy(user2));
    }

    [DataTestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void CanBeCancelledBy_IsUserCanCancelHisReservation_ReturnsCorrectCancellationPermission(bool isAdmin)
    {
        var user = new User { IsAdmin = isAdmin };

        Assert.AreEqual(true, new Reservation(user).CanBeCancelledBy(user));
    }
}