using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System252 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component304> _p1;
EcsPool<Component9> _p2;
EcsPool<Component388> _p3;
EcsPool<Component345> _pl0;
EcsPool<Component429> _pl1;
EcsPool<Component152> _pl2;
EcsPool<Component157> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component304>().Inc<Component9>().Inc<Component388>().End();
   _p1 = _world.GetPool<Component304>();
   _p2 = _world.GetPool<Component9>();
   _p3 = _world.GetPool<Component388>();
   _pl0 = _world.GetPool<Component345>();
   _pl1 = _world.GetPool<Component429>();
   _pl2 = _world.GetPool<Component152>();
   _pl3 = _world.GetPool<Component157>();
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
