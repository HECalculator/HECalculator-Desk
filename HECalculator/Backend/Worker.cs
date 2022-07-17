using System;

public class Worker
{
	public Worker()
	{
		this.Inputs=new Inputs();
		this.Validations=new Validations(States);
		this.States=new States();
	}
	private Inputs _inputs;
	private Validations _validations;
	private States _states;

	public Inputs Inputs { get => _inputs; set => _inputs = value; }
	public Validations Validations{ get => _validations; set => _validations= value; }
	public States States{ get => _states; set => _states= value; }
}
