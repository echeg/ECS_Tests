using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System392 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component248> _p1;
EcsPool<Component399> _p2;
EcsPool<Component106> _p3;
EcsPool<Component284> _p4;
EcsPool<Component242> _pl0;
 public void Init (IEcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component248>().Inc<Component399>().Inc<Component106>().Inc<Component284>().End();
   _p1 = _world.GetPool<Component248>();
   _p2 = _world.GetPool<Component399>();
   _p3 = _world.GetPool<Component106>();
   _p4 = _world.GetPool<Component284>();
   _pl0 = _world.GetPool<Component242>();
 }
 public void Run (IEcsSystems systems) {
  foreach (int entity in _filter) {
   if (_p1.Has(entity))
   {
    _p1.Del(entity);
   }
   else
   {
    _p1.Add(entity);
   }
  }
 }
}

}
