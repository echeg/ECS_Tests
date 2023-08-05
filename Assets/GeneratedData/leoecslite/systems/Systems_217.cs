using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System217 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component303> _p1;
EcsPool<Component179> _p2;
EcsPool<Component55> _p3;
EcsPool<Component71> _pl0;
EcsPool<Component169> _pl1;
EcsPool<Component297> _pl2;
EcsPool<Component2> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component303>().Inc<Component179>().Inc<Component55>().End();
   _p1 = _world.GetPool<Component303>();
   _p2 = _world.GetPool<Component179>();
   _p3 = _world.GetPool<Component55>();
   _pl0 = _world.GetPool<Component71>();
   _pl1 = _world.GetPool<Component169>();
   _pl2 = _world.GetPool<Component297>();
   _pl3 = _world.GetPool<Component2>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_pl0.Has(entity))
   {
    q+=1;
    var component1 = _pl0.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl1.Has(entity))
   {
    q+=1;
    var component1 = _pl1.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl2.Has(entity))
   {
    q+=1;
    var component1 = _pl2.Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_pl3.Has(entity))
   {
    q+=1;
    var component1 = _pl3.Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
