using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System267 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component221> _p1;
EcsPool<Component34> _p2;
EcsPool<Component476> _p3;
EcsPool<Component42> _p4;
EcsPool<Component169> _pl0;
EcsPool<Component115> _pl1;
EcsPool<Component71> _pl2;
EcsPool<Component327> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component221>().Inc<Component34>().Inc<Component476>().Inc<Component42>().End();
   _p1 = _world.GetPool<Component221>();
   _p2 = _world.GetPool<Component34>();
   _p3 = _world.GetPool<Component476>();
   _p4 = _world.GetPool<Component42>();
   _pl0 = _world.GetPool<Component169>();
   _pl1 = _world.GetPool<Component115>();
   _pl2 = _world.GetPool<Component71>();
   _pl3 = _world.GetPool<Component327>();
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
