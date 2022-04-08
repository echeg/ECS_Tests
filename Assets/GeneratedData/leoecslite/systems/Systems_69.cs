using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System69 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component135> _p1;
EcsPool<Component453> _p2;
EcsPool<Component413> _p3;
EcsPool<Component187> _p4;
EcsPool<Component152> _pl0;
EcsPool<Component446> _pl1;
EcsPool<Component269> _pl2;
EcsPool<Component396> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component135>().Inc<Component453>().Inc<Component413>().Inc<Component187>().End();
   _p1 = _world.GetPool<Component135>();
   _p2 = _world.GetPool<Component453>();
   _p3 = _world.GetPool<Component413>();
   _p4 = _world.GetPool<Component187>();
   _pl0 = _world.GetPool<Component152>();
   _pl1 = _world.GetPool<Component446>();
   _pl2 = _world.GetPool<Component269>();
   _pl3 = _world.GetPool<Component396>();
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
