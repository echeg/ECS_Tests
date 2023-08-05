using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System47 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component172> _p1;
EcsPool<Component204> _p2;
EcsPool<Component472> _p3;
EcsPool<Component290> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component172>().Inc<Component204>().Inc<Component472>().Inc<Component290>().End();
   _p1 = _world.GetPool<Component172>();
   _p2 = _world.GetPool<Component204>();
   _p3 = _world.GetPool<Component472>();
   _p4 = _world.GetPool<Component290>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  }
 }
}

}
