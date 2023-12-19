import React, { useState } from 'react';
import "./Input.css"

const Input = (props) => {

    return (
        <>
            <input type={props.type}
                placeholder={props.placeholder}
                name={props.name}
                id={props.id}
                value={props.value}
                onChange={props.onChange}
            />
        </>
    );
};

export default Input;
