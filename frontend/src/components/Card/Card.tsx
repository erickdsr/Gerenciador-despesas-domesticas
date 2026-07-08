import type { ReactNode } from 'react'

// Container visual reutilizavel para destacar blocos de informacao.
interface CardProps {
  children: ReactNode
  className?: string
}

export function Card({ children, className = '' }: CardProps) {
  return <section className={`card ${className}`.trim()}>{children}</section>
}
