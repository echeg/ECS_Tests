using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System201 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component411> _p1;
EcsPool<Component53> _p2;
EcsPool<Component278> _p3;
EcsPool<Component429> _pl0;
EcsPool<Component221> _pl1;
EcsPool<Component403> _pl2;
EcsPool<Component11> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component411>().Inc<Component53>().Inc<Component278>().End();
   _p1 = _world.GetPool<Component411>();
   _p2 = _world.GetPool<Component53>();
   _p3 = _world.GetPool<Component278>();
   _pl0 = _world.GetPool<Component429>();
   _pl1 = _world.GetPool<Component221>();
   _pl2 = _world.GetPool<Component403>();
   _pl3 = _world.GetPool<Component11>();
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
