<?php

class clsPractica1{
    
    private $Codigo;
    private $Seccion;
    private $FondoEmp; 
    private $HorasBasDia;
    private $HorasBasNoche;
    private $HorasBasDomDia;
    private $HorasBasDomNoche;
    private $HorasExtDia;
    private $HorasExtNoche;
    private $HorasExtDomDia;
    private $HorasExtDomNoche;
    
    private $Bruto;
    private $SubsTte;
    private $Neto;
    
    private $Salud;
    private $Pension;
    private $Paraf;
    
    private $VrHora;
    private $VrHoraAdmin;
    private $VrHoraProd;
    private $PorRetSalud;
    private $PorRetPension;
    private $PorRetParaf;
    private $PorIncOrdNoche;
    private $PorIncOrdDomDia;
    private $PorIncOrdDomNoche;
    private $PorIncExtOrdDia;
    private $PorIncExtOrdNoche;
    private $PorIncExtDomDia;
    private $PorIncExtDomNoche;
    
    private $SMLV;
    private $VrSubsTte;
    
    
    public function __construct(){
        $this->Codigo = 0;
        $this->FondoEmp = 0;
        $this->Seccion = 0;
        $this->HorasBasDia = 0;
        $this->HorasBasNoche = 0;
        $this->HorasBasDomDia = 0;
        $this->HorasBasDomNoche = 0;
        $this->HorasExtDia = 0;
        $this->HorasExtNoche = 0;
        $this->HorasExtDomDia = 0;
        $this->HorasExtDomNoche = 0;
        
        $this->Bruto =0;
        $this->SubsTte = 0;
        $this->Neto = 0;

        $this->Salud = 0;
        $this->Pension = 0;
        $this->Paraf = 0;
    
        $this->VrHoraAdmin = 0;
        $this->VrHoraAdmin = 10000;
        $this->VrHoraProd = 8350;
        $this->PorRetSalud = 0.04;
        $this->PorRetPension = 0.04;
        $this->PorRetParaf = 0.05;
        $this->PorIncOrdNoche = 1.35;
        $this->PorIncOrdDomDia = 1.75;
        $this->PorIncOrdDomNoche = 2.1;
        $this->PorIncExtOrdDia = 1.25;
        $this->PorIncExtOrdNoche = 2.0;
        $this->PorIncExtDomDia = 1.75;
        $this->PorIncExtDomNoche = 2.5;
    
        $this->SMLV = 616000;
        $this->VrSubsTte = 72000;
    }
    
    public function setSeccion($Seccion){
        $this->Seccion = $Seccion;
    }
    
    public function setFondoEmp($FondoEmp){
        $this->FondoEmp = $FondoEmp;
    }
    
    public function getFondoEmp(){
        return $this->FondoEmp;
    }
    
    public function setHorasBasDia($HorasBasDia){
        $this->HorasBasDia = $HorasBasDia;
    }
    
    public function setHorasBasNoche($HorasBasNoche){
        $this->HorasBasNoche = $HorasBasNoche;
    }
    
    public function setHorasBasDomDia($HorasBasDomDia){
        $this->HorasBasDomDia = $HorasBasDomDia;
    }
    
    public function setHorasBasDomNoche($HorasBasDomNoche){
        $this->HorasBasDomNoche = $HorasBasDomNoche;
    }
    
    public function setHorasExtDia($HorasExtDia){
        $this->HorasExtDia = $HorasExtDia;
    }
    
    public function setHorasExtNoche($HorasExtNoche){
        $this->HorasExtNoche = $HorasExtNoche;
    }
    
    public function setHorasExtDomDia($HorasExtDomDia){
        $this->HorasExtDomDia = $HorasExtDomDia;
    }
    
    public function setHorasExtDomNoche($HorasExtDomNoche){
        $this->HorasExtDomNoche = $HorasExtDomNoche;
    }
    
    
    
    
    public function getBruto(){
        return $this->Bruto;
    }
    
    public function getSubsidioTte(){
        return $this->SubsTte;
    }
    
    public function getNeto(){
        return $this->Neto;
    }
    
    public function getSalud(){
        return $this->Salud;
    }
    
    public function getpension(){
        return $this->Pension;
    }
    
    public function getParaiscales(){
        return $this->Paraf;
    }
    
    
    public function Calcular(){
        if($this->Seccion == 1){
            $this->VrHora = $this->VrHoraAdmin;
        }
        else{
            $this->VrHora = $this->VrHoraProd;
        }
        
        $this->Bruto = ($this->HorasBasDia * $this->VrHora) +
                       ($this->HorasBasNoche * $this->VrHora * $this->PorIncOrdNoche) +
                       ($this->HorasBasDomDia * $this->VrHora * $this->PorIncOrdDomDia) +
                       ($this->HorasBasDomNoche * $this->VrHora * $this->PorIncOrdDomNoche) +
                       ($this->HorasExtDia * $this->VrHora * $this->PorIncExtOrdDia) +
                       ($this->HorasExtNoche * $this->VrHora * $this->PorIncExtOrdNoche) +
                       ($this->HorasExtDomDia * $this->VrHora * $this->PorIncExtDomDia) +
                       ($this->HorasExtDomNoche * $this->VrHora * $this->PorIncExtDomNoche);
                       
        if($this->Bruto <= 2.0 * $this->SMLV ){
            $this->SubsTte = $this->VrSubsTte;
        }
        
         
        $this->Salud = $this->Bruto * $this->PorRetSalud;

        $this->Pension = $this->Bruto * $this->PorRetPension;

        $this->Paraf = $this->Bruto * $this->PorRetParaf;

        $this->Neto = $this->Bruto + $this->SubsTte -
                      ($this->Salud + $this->Pension + $this->Paraf + $this->FondoEmp); 
        return true;
    }
}

?>