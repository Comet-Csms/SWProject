using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;
public class DogRayAgent : Agent
{
    private new Transform transform;
    private new Rigidbody rigidbody;

    public float moveSpeed = 1.5f;
    public float turnSpeed = 200.0f;
    public override void Initialize()
    {
        // �� ���Ǽҵ�(�н�����) �� �õ� Ƚ��
        MaxStep = 5000;

        transform = GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody>();

    }
    public override void OnEpisodeBegin()
    {
        // �������� �ʱ�ȭ

        // �������� �ʱ�ȭ
        rigidbody.velocity = rigidbody.angularVelocity = Vector3.zero;

        // ������Ʈ�� ��ġ�� ����
        Vector3 alpha = new Vector3(1, 0, 1);
        transform.position = GameObject.Find("Player").transform.position + alpha;
        // training code
        //transform.position = new Vector3(227, 40, 244);
        //transform.localPosition = new Vector3(Random.Range(-22.0f, 22.0f), 0.05f, Random.Range(-22.0f, 22.0f));

        // ������Ʈ�� ȸ���� ����
        transform.localRotation = Quaternion.Euler(Vector3.up * Random.Range(0, 360));
    }

    public override void CollectObservations(VectorSensor sensor)
    {
    }
    public override void OnActionReceived(ActionBuffers actions)
    {
        var action = actions.DiscreteActions;
        Debug.Log($"[0] = {action[0]}, [1]: {action[1]}");

        Vector3 dir = Vector3.zero;
        Vector3 rot = Vector3.zero;

        // Branch 0 : ���� / ���� / ����
        switch (action[0])
        {
            case 1: dir = transform.forward; break;
            case 2: dir = -transform.forward; break;
        }

        // Branch 1: ���� / ��ȸ�� / ��ȸ��
        switch (action[1])
        {
            case 1: rot = transform.up; break;
            case 2: rot = -transform.up; break;
        }

        transform.Rotate(rot, Time.fixedDeltaTime * turnSpeed);
        rigidbody.AddForce(dir * moveSpeed, ForceMode.VelocityChange);

        // ���̳ʽ� �г�Ƽ�� ����
        AddReward(-1 / (float)MaxStep);
    }
    public override void Heuristic(in ActionBuffers actionsOut)
    {
        var action = actionsOut.DiscreteActions;

        actionsOut.Clear();

        if (Input.GetKey(KeyCode.W))
        {
            action[0] = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            action[0] = 2;
        }
        if (Input.GetKey(KeyCode.A))
        {
            action[1] = 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            action[1] = 2;
        }
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("Enemy"))
        {
            // ���ӵ��� ���� �� �ֱ� ������ ������ �ʱ�ȭ
            rigidbody.velocity = rigidbody.angularVelocity = Vector3.zero;
            
            Destroy(coll.gameObject);
            AddReward(1.5f);
        }

        if (coll.collider.CompareTag("PP"))
        {
            AddReward(-1.0f);
            EndEpisode();
        }

        if (coll.collider.CompareTag("wall"))
        {
            AddReward(-0.1f);
        }

        if (coll.collider.CompareTag("wall2"))
        {
            AddReward(-0.05f);
        }
    }
}