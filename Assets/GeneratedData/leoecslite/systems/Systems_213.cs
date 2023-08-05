using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System213 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component471> _p1;
EcsPool<Component389> _p2;
EcsPool<Component252> _p3;
EcsPool<Component470> _p4;
EcsPool<Component39> _pl0;
EcsPool<Component383> _pl1;
EcsPool<Component167> _pl2;
EcsPool<Component353> _pl3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component471>().Inc<Component389>().Inc<Component252>().Inc<Component470>().End();
   _p1 = _world.GetPool<Component471>();
   _p2 = _world.GetPool<Component389>();
   _p3 = _world.GetPool<Component252>();
   _p4 = _world.GetPool<Component470>();
   _pl0 = _world.GetPool<Component39>();
   _pl1 = _world.GetPool<Component383>();
   _pl2 = _world.GetPool<Component167>();
   _pl3 = _world.GetPool<Component353>();
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
