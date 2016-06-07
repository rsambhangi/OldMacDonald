using System;
using System.Threading;
class M{static void Main(){string Z="wow",G="chick";
Func<string,string> d=(e)=>e+="E-I-E-I-O.\n\n",f=(g)=>g+="Old MacDonald had a farm,\n",T=(S)=>d(S),h=(i)=>i+=new string('-',40)+"\n\n",D=(E)=>T(f(h(T(f(E+"\n")))));
Func<string,int,string,string> j=(k,W,l)=>l+=$"And on his farm he had some {k},\n",y=(A,B,C)=>{C+=$"Everywhere a {A}, ";C+=B>0?Z:A;return C+=",\n";},u=(v,w,x)=>{x+=$"Here a {v}, there a ";x+=w>0?Z:v;return y(v,w,x+=",\n");},q=(r,s,t)=>{t+=$"And a {r}, ";t+=s>0?Z:r;return u(r,s,t+=" there,\n");},m=(n,o,p)=>{p+=$"With a {n}, ";p+=o>0?Z:n;return q(n,o,p+=" here,\n");};
Console.Write(T(f(m("baa",0,T(j("sheep",0,D(m("oink",0,T(j("pigs",0,D(m("bow",1,T(j("dogs",0,D(m("meow",0,T(j("cats",0,D(m("moo",0,T(j("cows",0,D(m("quack",0,(d(j("ducks",0,D(m(G,0,d(j(G+"s",0,d(f("")))))))))))))))))))))))))))))) + "\n")));
Thread.Sleep(100000);}}