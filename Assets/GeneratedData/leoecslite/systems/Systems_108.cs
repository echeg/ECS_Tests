using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System108 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component242> _p1;
EcsPool<Component356> _p2;
EcsPool<Component51> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component242>().Inc<Component356>().Inc<Component51>().End();
   _p1 = _world.GetPool<Component242>();
   _p2 = _world.GetPool<Component356>();
   _p3 = _world.GetPool<Component51>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
