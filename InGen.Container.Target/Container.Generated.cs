// <auto-generated/>

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using InGen.Exceptions;
using InGen.Injector;
using JetBrains.Annotations;

namespace InGen.Target;

[GeneratedCode("InGen", "0.0.01")]
public partial class Container : 
    IContainer,
    IResolver<FooStruct>,
    IResolver<IFoo>,
    IResolver<SingleClass>,
    IResolver<ScopedClass>,
    IResolver<TransientClass>,
    IResolver<ClassWithDependency>
{

    protected readonly List<IContainer> _children = new List<IContainer>();
    
    private IContainer _rootScope;
    protected IContainer RootScope => _rootScope ??= CreateRootScope();
    
    protected virtual IContainer CreateRootScope() => new Scope(this);

    #region IContainer

    public T Resolve<T>([CanBeNull] object id = null)
    {
        if (this is IResolver<T> resolver)
            return resolver.Resolve(id);

        throw new FailedToResolveException(this, typeof(T), id);
    }
    
    public virtual IResult<T> TryResolve<T>([CanBeNull] object id = null)
    {
        if (this is IResolver<T> resolver)
            return Result.FromValue(resolver.Resolve(id));

        return Result.FromException<T>(new FailedToResolveException(this, typeof(T), id));
    }

    public virtual object Resolve(Type type, [CanBeNull] object id = null)
    {
        if(type == typeof(FooStruct))
            //Structs needs to be boxed
            return Resolve<FooStruct>(id);
        
        if(type == typeof(IFoo))
            return Resolve<IFoo>(id);
            
        if(type == typeof(SingleClass))
            return Resolve<SingleClass>(id);
        
        if(type == typeof(ScopedClass))
            return Resolve<ScopedClass>(id);
            
        if(type == typeof(TransientClass))
            return Resolve<TransientClass>(id);

        if (type == typeof(ClassWithDependency))
            return Resolve<ClassWithDependency>();
        
        throw new FailedToResolveException(this, type, id);
    }
    
    public virtual IResult<object> TryResolve(Type type, [CanBeNull] object id = null)
    {
        if(type == typeof(FooStruct))
            //Structs needs to be boxed
            return TryResolve<FooStruct>(id).Box();
        
        if(type == typeof(IFoo))
            return TryResolve<IFoo>(id);
            
        if(type == typeof(SingleClass))
            return TryResolve<SingleClass>(id);
        
        if(type == typeof(ScopedClass))
            return TryResolve<ScopedClass>(id);
            
        if(type == typeof(TransientClass))
            return TryResolve<TransientClass>(id);

        if (type == typeof(ClassWithDependency))
            return TryResolve<ClassWithDependency>();
        
        return Result.FromException<object>(new FailedToResolveException(this, type, id));
    }

    public virtual IContainer CreateScope()
    {
        var scope = new Scope(this);
        _children.Add(scope);
        return scope;
    }

    public virtual void Dispose()
    {
        //Dispose all IDisposable fields

        foreach (var child in _children) 
            child.Dispose();
    }

    #endregion
        
    #region Resolvers
    
    //Structs are nullable
    private FooStruct? __InGenContainerTargetFoo;

    FooStruct IResolver<FooStruct>.Resolve(object id)
    {
        return id switch
        {
            null => __InGenContainerTargetFoo ??= new FooStruct(),
            _ => throw new FailedToResolveException(this, typeof(FooStruct), id)
        };
    }

    IFoo IResolver<IFoo>.Resolve(object id)
        => Resolve<FooStruct>(id);

    private SingleClass __InGenContainerTargetSingleClass;

    SingleClass IResolver<SingleClass>.Resolve(object id)
    {
        return id switch
        {
            null => __InGenContainerTargetSingleClass ??= new SingleClass(),
            _ => throw new FailedToResolveException(this, typeof(SingleClass), id)
        };
    }

    ScopedClass IResolver<ScopedClass>.Resolve(object id)
        => RootScope.Resolve<ScopedClass>();

    TransientClass IResolver<TransientClass>.Resolve(object id)
    {
        return id switch
        {
            null => new TransientClass(),
            _ => throw new FailedToResolveException(this, typeof(TransientClass), id)
        };
    }

    private ClassWithDependency __InGenContainerTargetClassWithDependency;
    
    private DependentClass __InGenContainerTargetDependentClass_For_InGenContainerTargetClassWithDependency;
    private DependentClass Get_InGenContainerTargetDependentClass_For_InGenContainerTargetClassWithDependency()
    {
        if (__InGenContainerTargetDependentClass_For_InGenContainerTargetClassWithDependency != null)
            return __InGenContainerTargetDependentClass_For_InGenContainerTargetClassWithDependency;

        return __InGenContainerTargetDependentClass_For_InGenContainerTargetClassWithDependency = new DependentClass();
    }
    
    ClassWithDependency IResolver<ClassWithDependency>.Resolve(object id)
    {
        if (__InGenContainerTargetClassWithDependency != null)
            return __InGenContainerTargetClassWithDependency;
        
        //Parameter
        var InGenContainerTargetDependentClassParam = Get_InGenContainerTargetDependentClass_For_InGenContainerTargetClassWithDependency();
        return __InGenContainerTargetClassWithDependency = new ClassWithDependency(InGenContainerTargetDependentClassParam);
    }

    #endregion
        
    [GeneratedCode("InGen", "0.0.01")]
    public class Scope : 
        IContainer,
        IResolver<FooStruct>,
        IResolver<IFoo>,
        IResolver<SingleClass>,
        IResolver<ScopedClass>,
        IResolver<TransientClass>,
        IResolver<ClassWithDependency>
    {
        protected IContainer _root;
        protected readonly List<IContainer> _children = new List<IContainer>(); 

        public Scope(IContainer root)
        {
            _root = root;
        }
        
        #region IContainer

        public T Resolve<T>([CanBeNull] object id)
        {
            if (this is IResolver<T> resolver)
                return resolver.Resolve(id);

            throw new FailedToResolveException(this, typeof(T), id);
        }
        
        public IResult<T> TryResolve<T>(object id)
        {
            if (this is IResolver<T> resolver)
                return Result<T>.FromValue(resolver.Resolve(id));
            
            return Result.FromException<T>(new FailedToResolveException(this, typeof(T), id));
        }
        
        public virtual object Resolve(Type type, [CanBeNull] object id = null)
        {
            if(type == typeof(FooStruct))
                //Structs needs to be boxed
                return Resolve<FooStruct>(id);
        
            if(type == typeof(IFoo))
                return Resolve<IFoo>(id);
            
            if(type == typeof(SingleClass))
                return Resolve<SingleClass>(id);
        
            if(type == typeof(ScopedClass))
                return Resolve<ScopedClass>(id);
            
            if(type == typeof(TransientClass))
                return Resolve<TransientClass>(id);

            if (type == typeof(ClassWithDependency))
                return Resolve<ClassWithDependency>(id);
        
            throw new FailedToResolveException(this, type, id);
        }

        public virtual IResult<object> TryResolve(Type type, object id)
        {
            if (type == typeof(FooStruct))
                return TryResolve<FooStruct>(id).Box();
            
            if(type == typeof(Foo))
                return TryResolve<Foo>(id);
        
            if(type == typeof(IFoo))
                return TryResolve<IFoo>(id);
            
            if(type == typeof(SingleClass))
                return TryResolve<SingleClass>(id);
        
            if(type == typeof(ScopedClass))
                return TryResolve<ScopedClass>(id);
            
            if(type == typeof(TransientClass))
                return TryResolve<TransientClass>(id);

            if (type == typeof(ClassWithDependency))
                return TryResolve<ClassWithDependency>(id);
        
            return Result.FromException<object>(new FailedToResolveException(this, type, id));
        }
        
        public virtual IContainer CreateScope()
        {
            var scope = new Scope(this);
            _children.Add(scope);
            return scope;
        }

        public virtual void Dispose()
        {
            //Dispose all IDisposable fields

            foreach (var child in _children) 
                child.Dispose();
        }

        #endregion
            
        #region Resolvers
        
        FooStruct IResolver<FooStruct>.Resolve([CanBeNull] object id)
            => _root.Resolve<FooStruct>();

        IFoo IResolver<IFoo>.Resolve([CanBeNull] object id)
            => _root.Resolve<IFoo>();

        SingleClass IResolver<SingleClass>.Resolve([CanBeNull] object id)
            => _root.Resolve<SingleClass>();

        private ScopedClass __InGenContainerTargetScopedClass;
            
        ScopedClass IResolver<ScopedClass>.Resolve([CanBeNull] object id)
            => __InGenContainerTargetScopedClass 
                ??= new ScopedClass();

        TransientClass IResolver<TransientClass>.Resolve([CanBeNull] object id)
            => new TransientClass();

        ClassWithDependency IResolver<ClassWithDependency>.Resolve([CanBeNull] object id)
            => _root.Resolve<ClassWithDependency>();

        #endregion}
    }
}