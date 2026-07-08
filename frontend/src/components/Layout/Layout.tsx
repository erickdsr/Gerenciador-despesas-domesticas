import type { ReactNode } from 'react'
import { Navbar } from '../Navbar'

// Layout compartilhado que envolve todas as paginas com a navegacao principal.
interface LayoutProps {
  children: ReactNode
}

export function Layout({ children }: LayoutProps) {
  return (
    <div className="app-shell">
      <Navbar />
      <main className="main-container">{children}</main>
    </div>
  )
}
