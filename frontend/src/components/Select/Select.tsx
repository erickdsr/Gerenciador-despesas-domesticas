import type { SelectHTMLAttributes } from 'react'

// Campo select com label padronizado para formularios da aplicacao.
interface SelectProps extends SelectHTMLAttributes<HTMLSelectElement> {
  label: string
}

export function Select({ id, label, className = '', children, ...props }: SelectProps) {
  const selectId = id ?? props.name

  return (
    <label className="field" htmlFor={selectId}>
      <span>{label}</span>
      <select id={selectId} className={`select ${className}`.trim()} {...props}>
        {children}
      </select>
    </label>
  )
}
