#pragma once


class Addmethod
{
public:
	virtual int add(int a, int b) { return 0; };
	virtual ~Addmethod() {}
};

class CPlusPlusClass
{
public:
	// 测试对C++模块中定义的Class的调用  
	int Add(int a,int b,Addmethod* method);
};
