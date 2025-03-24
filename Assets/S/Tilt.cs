using UnityEngine;

public class Tilt : MonoBehaviour
{
    public float tiltSpeed = 30f; // ความเร็วในการเอียง
    public float maxTiltAngle = 30f; // จำกัดมุมเอียงสูงสุด

    private float currentTiltX = 0f; // มุมเอียงในแกน X
    private float currentTiltY = 0f; // มุมเอียงในแกน Y (ไม่ใช้ แต่กันไว้)
    private float currentTiltZ = 0f; // มุมเอียงในแกน Z

    void Update()
    {
        // รับค่า Input จากปุ่ม WASD
        float tiltX = -Input.GetAxis("Horizontal") * tiltSpeed * Time.deltaTime; // W = เอียงขึ้น, S = เอียงลง
        float tiltZ = -Input.GetAxis("Vertical") * tiltSpeed * Time.deltaTime; // A = เอียงซ้าย, D = เอียงขวา


        // จำกัดค่ามุมเอียงไม่ให้เกินขอบเขต
        currentTiltX = Mathf.Clamp(currentTiltX + tiltX, -maxTiltAngle, maxTiltAngle);
        currentTiltZ = Mathf.Clamp(currentTiltZ + tiltZ, -maxTiltAngle, maxTiltAngle);

        // ใช้ Quaternion เพื่อลดปัญหา Gimbal Lock และทำให้การหมุนสมูท
        transform.rotation = Quaternion.Euler(currentTiltX, 0, currentTiltZ);
    }
}
