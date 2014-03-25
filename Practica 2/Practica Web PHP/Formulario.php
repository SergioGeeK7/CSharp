<?php
$bruto = 0;
$subTte = 0;
$neto = 0;
$salud = 0;
$pension = 0;
$paraf = 0;
$fondo = 0;

if(isset($_POST['procesar'])){
include "clsPractica1.php";
$nomina = new clsPractica1();

$nomina->setSeccion($_POST['seccion']);
$nomina->setFondoEmp($_POST['fondo']);
$nomina->setHorasBasDia($_POST['horasbasdia']);
$nomina->setHorasBasNoche($_POST['horasbasnoche']);
$nomina->setHorasBasDomDia($_POST['horasdomdia']);
$nomina->setHorasBasDomNoche($_POST['horasdomnoche']);

$nomina->setHorasExtDia($_POST['horasextorddia']);
$nomina->setHorasExtNoche($_POST['horasextordnoche']);
$nomina->setHorasExtDomDia($_POST['horasextdomdia']);
$nomina->setHorasExtDomNoche($_POST['horasextdomnoche']);

$nomina->Calcular();

$bruto = $nomina->getBruto();
$subTte = $nomina->getSubsidioTte();
$neto = $nomina->getNeto();
$salud = $nomina->getSalud();
$pension = $nomina->getpension();
$paraf = $nomina->getParaiscales();
$fondo = $nomina->getFondoEmp();
}

?>

<!DOCTYPE html>
<html>
<head>
    <title>Nomina</title>
    <link rel="stylesheet" href="estilos.css"/>
    <script src="js.js"></script>
</head>
<body>
    <div class="contenedor">
    <h1>SISTEMA DE NOMINA</h1>
    <section class="formulario">
        <form method="post" action="<?php echo $_SERVER['PHP_SELF']; ?>" name="form">
        <section class="codigo">
            <label>Codigo</label>
            <input type="number" min="0" max="100" name="codigo" id="codigo" placeholder="Codigo" required/>
        </section>
        <section class="seccion">
            <fieldset>
                <legend>Sección</legend>
                    <label>Admon</label>
                    <input type="radio" name="seccion" checked="checked"  value="1"/>
                    <label>Producción</label>
                    <input type="radio" name="seccion"  value="2"/>
            </fieldset>
        </section>
        <section class="fondo">
            <label>Fondo Empleados</label>
            <input type="number" min="0" max="100000000" name="fondo" id="fondo" value="0" placeholder="Fondo"/>
        </section>
        <fieldset>
        <legend>Horas Trabajadas</legend>
        <table>
            <tr>
                <td>Basicas</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td>Extras</td>
            </tr>
            <tr>
                <td></td>
                <td>Diurna</td>
                <td>Nocturna</td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td>Diurna</td>
                <td></td>
                <td>Nocturna</td>
            </tr>
            <tr>
                <td>Ordinarias</td>
                <td><input type="number"  name="horasbasdia" id="horasbasdia" min="0" max="100" placeholder="Basicas" required/></td>
                <td><input type="number" name="horasbasnoche" min="0" max="100" placeholder="Basicas" /></td>
                <td></td>
                <td></td>
                <td>Ordinarias</td>
                <td><input type="checkbox" name="extordia" id="extordia" onclick="mostrarEOD()"/></td>
                <td><input type="number" min="0" max="100" placeholder="Extras" name="horasextorddia" id="horasextorddia" style="visibility:hidden" /></td>
                <td><input type="checkbox" name="extornoche" id="extornoche" onclick="mostrarEON()"/></td>
                <td><input type="number" min="0" max="100" placeholder="Extras" name="horasextordnoche" id="horasextordnoche" style="visibility:hidden" /></td>
            </tr>
            <tr>
                <td>Dom/Fest</td>
                <td><input type="number" min="0" max="100" name="horasdomdia" placeholder="Basicas"/></td>
                <td><input type="number" min="0" max="100" name="horasdomnoche" placeholder="Basicas" /></td>
                <td></td>
                <td></td>
                <td>Dom/Fest</td>
                <td><input type="checkbox" id="extdomdia" onclick="mostrarEDD()" /></td>
                <td><input type="number" min="0" max="100" placeholder="Extras" name="horasextdomdia" id="horasextdomdia"  style="visibility:hidden" /></td>
                <td><input type="checkbox" id="extdomnoche" onclick="mostrarEDN()" /></td>
                <td><input type="number" min="0" max="100" placeholder="Extras" name="horasextdomnoche"  id="horasextdomnoche" style="visibility:hidden" /></td>
            </tr>
        </table>
        </fieldset>
        <section>
            <input type="submit" id="procesar" name="procesar" value="Procesar" />
        </section>
    </form>
    </section>
    <section class="devengado">
        <fieldset>
        <legend>Devengado</legend>
        <table>
            <tr>
                <td>Bruto</td>
                <td><input type="text" placeholder="Salario Bruto" value="<?php echo "$bruto"?>" readonly/></td>
            </tr>
            <tr>
                <td>Subs. Tte</td>
                <td><input type="text" placeholder="Subsidio de Transporte" value="<?php echo "$subTte"?>" readonly/></td>
            </tr>
            <tr>
                <td>Neto</td>
                <td><input type="text" placeholder="Salario Neto" value="<?php echo "$neto"?>" readonly/></td>
            </tr>
        </table>
        </fieldset>
    </section>
    <section class="deduciones">
        <fieldset>
        <legend>Deducciones</legend>
        <table>
            <tr>
                <td>Salud</td>
                <td><input type="text" placeholder="Salud" value="<?php echo "$salud"?>" readonly/></td>
            </tr>
            <tr>
                <td>Pensión</td>
                <td><input type="text" placeholder="Pensión" value="<?php echo "$pension"?>" readonly/></td>
            </tr>
            <tr>
                <td>Parafiscales</td>
                <td><input type="text" placeholder="Parafiscales" value="<?php echo "$paraf"?>" readonly/></td>
            </tr>
            <tr>
                <td>Fondo Emp</td>
                <td><input type="text" placeholder="Fondo de Empleado" value="<?php echo "$fondo"?>" readonly/></td>
            </tr>
        </table>
        </fieldset>
    </section>
    </div>
</body>
</html>

