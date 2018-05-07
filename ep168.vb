'=== object ROTATION ======
X1=X
Y1=Y*cos(XAA)-Z*sin(XAA)
Z1=Y*sin(XAA)+Z*cos(XAA)
X2=X1*cos(YAA)+Z1*sin(YAA)
Y2=Y1
Z2=-X1*sin(YAA)+Z1*cos(YAA)
X=X2*cos(ZAA)-Y2*sin(ZAA)
Y=X2*sin(ZAA)+Y2*cos(ZAA)
Z=Z2
return
'=== world ROTATION ======
X1=X
Y1=Y*cos(XA)-Z*sin(XA)
Z1=Y*sin(XA)+Z*cos(XA)
X2=X1*cos(YA)+Z1*sin(YA)
Y2=Y1
Z2=-X1*sin(YA)+Z1*cos(YA)
X=X2*cos(ZA)-Y2*sin(ZA)
Y=X2*sin(ZA)+Y2*cos(ZA)
Z=Z2
return
'-=== CONVERGENCE LEFT-EYE
C=5
CONVX=X*cos(CA)+Z*sin(CA)
CONVY=Y
CONVZ=-X*sin(CA)+Z*cos(CA)
X=CONVX
Y=CONVY
Z=CONVZ
return
'-=== CONVERGENCE RIGHT-EYE
C=3
