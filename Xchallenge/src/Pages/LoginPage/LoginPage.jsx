import React from 'react';
import "./LoginPage.css";
import { Button, Input, Label } from '../../Components/FormComponents/FormComponents';
import Container from '../../Components/Container/Container';

const LoginPage = () => {
    return (
        <>
        <section className='formLogin'>
        <Container>
            <div className="form-flex">

            <form action="" className='loginForm'>
                <h1>Login</h1>
                <p>Digite seus dados de acesso no campo abaixo.</p>
                <Label 
                labelText="Email"
                />
                <Input 
                placeholder="Digite seu e-mail"
                additionalClass='inputLogin'
                />
                <Label
                labelText="Senha"
                />
                <Input
                additionalClass='inputLogin'
                placeholder="Digite sua senha"
                />

                <Button 
                textButton="Logar"
                additionalClass="btnLogin"
                />
            </form>
            </div>

        </Container>
        </section>
        </>
    );
};

export default LoginPage;