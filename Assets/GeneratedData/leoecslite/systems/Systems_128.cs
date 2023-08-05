using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System128 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component52> _p1;
EcsPool<Component163> _p2;
EcsPool<Component150> _p3;
EcsPool<Component177> _p4;
EcsPool<Component360> _pl0;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component52>().Inc<Component163>().Inc<Component150>().Inc<Component177>().End();
   _p1 = _world.GetPool<Component52>();
   _p2 = _world.GetPool<Component163>();
   _p3 = _world.GetPool<Component150>();
   _p4 = _world.GetPool<Component177>();
   _pl0 = _world.GetPool<Component360>();
 }
 public void Run (EcsSystems systems) {
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
